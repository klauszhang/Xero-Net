using System;
using System.IO;
using System.Net;
using System.Text;

namespace Xero.Api.Infrastructure.Http
{
  internal class Response
  {
    private string _body;

    internal Response(HttpWebResponse inner)
    {
      StatusCode = inner.StatusCode;
      ContentLength = (int)inner.ContentLength;
      ContentType = inner.ContentType;

      var stream = inner.GetResponseStream();
      if (stream != null)
      {
        HttpWebRequest.DefaultMaximumErrorResponseLength = ContentLength;
        var result = Encoding.Default.GetString(ReadFully(stream, ContentLength));

        Stream = new MemoryStream();
        var writer = new StreamWriter(Stream);
        writer.Write(result);
        writer.Flush();
        Stream.Position = 0;
      }
    }

    public string Body
    {
      get
      {
        if (_body != null)
          return _body;

        //Cache the body so it can be examined more than once when debugging
        using (var rdr = new StreamReader(Stream))
        {
          var result = rdr.ReadToEnd();

          Stream.Seek(0, SeekOrigin.Begin);

          _body = result;
        }

        return _body;
      }
    }

    public Stream Stream { get; private set; }

    public HttpStatusCode StatusCode { get; private set; }

    public int ContentLength { get; private set; }

    public string ContentType { get; private set; }

    /// <summary>
    /// Reads data from a stream until the end is reached. The
    /// data is returned as a byte array. An IOException is
    /// thrown if any of the underlying IO calls fail.
    /// </summary>
    /// <param name="stream">The stream to read data from</param>
    /// <param name="initialLength">The initial buffer length</param>
    public static byte[] ReadFully(Stream stream, int initialLength)
    {
      // If we've been passed an unhelpful initial length, just
      // use 32K.
      if (initialLength < 1)
      {
        initialLength = 32768;
      }


      byte[] buffer = new byte[initialLength];
      int read = 0;


      int chunk;
      while ((chunk = stream.Read(buffer, read, buffer.Length - read)) > 0)
      {
        read += chunk;


        // If we've reached the end of our buffer, check to see if there's
        // any more information
        if (read == buffer.Length)
        {
          int nextByte = stream.ReadByte();


          // End of stream? If so, we're done
          if (nextByte == -1)
          {
            return buffer;
          }


          // Nope. Resize the buffer, put in the byte we've just
          // read, and continue
          byte[] newBuffer = new byte[buffer.Length * 2];
          Array.Copy(buffer, newBuffer, buffer.Length);
          newBuffer[read] = (byte)nextByte;
          buffer = newBuffer;
          read++;
        }
      }
      // Buffer is now too big. Shrink it.
      byte[] ret = new byte[read];
      Array.Copy(buffer, ret, read);
      return ret;
    }

  }
}