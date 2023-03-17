using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OOPBasics2
{
    public class PdfService
    {
        public static void GenerateNewPdfFileFromString(string path, string inputString)
        {
            try
            {
                PdfDocument document = new PdfDocument();
                PdfPage page = document.AddPage();
                XGraphics graphics = XGraphics.FromPdfPage(page);
                XFont font = new XFont("Arial", 12, XFontStyle.Regular);
                XRect rect = new XRect(80, 40, 80, 40);
                graphics.DrawString(inputString, font, XBrushes.Black, rect, XStringFormats.TopLeft);
                document.Save(path);
                document.Dispose();
            }
            catch (Exception ex)
            {

                Console.Error.WriteLine(ex.Message);
            }
        }

        public static void GenerateNewPdfFileFromStream(string path, MemoryStream stream )
        {
            try
            {
                PdfDocument document = new PdfDocument();
                PdfPage page = document.AddPage();
                XGraphics graphics = XGraphics.FromPdfPage(page);
                XFont font = new XFont("Arial", 12, XFontStyle.Regular);
                XRect rect = new XRect(80, 40, 80, 40);
                var text = System.Text.Encoding.UTF8.GetString(stream.ToArray());
                XTextFormatter tekst = new XTextFormatter(graphics);
                tekst.DrawString(text, font, XBrushes.Black, rect);                
                document.Save(path);
                document.Dispose();
            }
            catch (Exception ex)
            {

                Console.Error.WriteLine(ex.Message);
            }
           
            

        }
    }
}
