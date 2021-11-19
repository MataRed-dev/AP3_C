using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace AP3_FormaFlix
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void MainA()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormConnexion());
        }

        static void Main(string[] args)
        {
            // Must have write permissions to the path folder
            PdfWriter writer = new PdfWriter("C:\\Users\\gouda\\OneDrive\\Documents\\AP3\\AP3_C\\demo.pdf");
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);
            Paragraph header = new Paragraph("FORMAFLIX")
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(14);
            LineSeparator ls = new LineSeparator(lineDrawer: new SolidLine());
            Paragraph subheader = new Paragraph("CERTIFICAT DE SUIVI DE FORMATION")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(25);
            Paragraph presentation = new Paragraph("Ce certificat a été délivré par l'entreprise BG'S COORP")
                .SetFontSize(10)
                .SetTextAlignment(TextAlignment.LEFT);
            Paragraph ligne1 = new Paragraph("Délivré à (nom et prenom personne)");
            Paragraph ligne2 = new Paragraph("Conformément au règles établies sur le site WEB FormaFlix le 12 novembre 2021 par les responsables");


            document.Add(header);
            document.Add(ls);
            document.Add(subheader);
            document.Add(presentation);
            document.Add(ligne1);
            document.Add(ligne2);
            document.Close();
        }
    }
}
