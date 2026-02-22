using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac5
{

    public interface IReportBuilder
    {
        void SetHeader();
        void SetContect();
        void AddSection();
        void SetFooter();
        Report GetReport();
    }

    class TextReportBuilder : IReportBuilder
    {
        private Report _report = new Report();

        public Report Report { get => _report; set => _report = value; }

        public void SetHeader()
        {
            Report.Header = "текст хедер";
        }
        public void SetContect()
        {
            Report.Contect = "текст контент";
        }
        public void AddSection()
        {
            Report.Sections.Add("текст секция");
            Report.Sections.Add("текст секция2");
        }
        public void SetFooter()
        {
            Report.Footer = "Текстфутер";
        }
        public Report GetReport()
        {
            return Report;
        }
    }

    class HtmlReportBuilder : IReportBuilder
    {
        private Report _report = new Report();

        public Report Report { get => _report; set => _report = value; }

        public void SetHeader()
        {
            Report.Header = "html хедер";
        }
        public void SetContect()
        {
            Report.Contect = "html контент";
        }
        public void AddSection()
        {
            Report.Sections.Add("html секция");
            Report.Sections.Add("html секция2");
        }
        public void SetFooter()
        {
            Report.Footer = "html футер";
        }
        public Report GetReport()
        {
            return Report;
        }
    }

    class PdfReportBuilder : IReportBuilder
    {
        private Report _report = new Report();

        public Report Report { get => _report; set => _report = value; }

        public void SetHeader()
        {
            Report.Header = "pdf хедер";
        }
        public void SetContect()
        {
            Report.Contect = "pdf контент";
        }
        public void AddSection()
        {
            Report.Sections.Add("pdf секция");
            Report.Sections.Add("pdf секция2");
        }
        public void SetFooter()
        {
            Report.Footer = "pdf футер";
        }
        public Report GetReport()
        {
            return Report;
        }
    }

    class ReportDirector
    {
        private IReportBuilder _reportBuilder;
        public ReportDirector(IReportBuilder reportBuilder)
        {
            ReportBuilder = reportBuilder;
        }

        public IReportBuilder ReportBuilder { get => _reportBuilder; set => _reportBuilder = value; }

        public Report BuildReport()
        {
            ReportBuilder.SetHeader();
            ReportBuilder.SetContect();
            ReportBuilder.AddSection();
            ReportBuilder.SetFooter();
            return ReportBuilder.GetReport();
        }
    }


    public class Report
    {
        public string Header { get; set; }
        public string Contect { get; set; }
        public string Footer { get; set; }
        public List<string> Sections { get; }
        public Report()
        {
            Sections = new List<string>();
        }
        public void Export()
        {
            Console.WriteLine(Header);
            Console.WriteLine(Contect);
            foreach (string section in Sections)
            {
                Console.WriteLine(section);
            }
            Console.WriteLine(Footer);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HtmlReportBuilder builder = new HtmlReportBuilder();
            ReportDirector director = new ReportDirector(builder);
            director.BuildReport();
        }
    } 
}
