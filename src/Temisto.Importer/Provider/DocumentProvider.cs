using ClosedXML.Excel;
using Temisto.Domain.Models;
using Temisto.Importer.Config;

namespace Temisto.Importer.Provider
{
    public class DocumentProvider : IDocumentProvider
    {
        private readonly IDocumentProviderOptions _documentProviderOptions;
        public DocumentProvider(IDocumentProviderOptions documentProviderOptions)
        {
            _documentProviderOptions = documentProviderOptions;
        }
        public IEnumerable<HeroDTO> GetHero()
        {
            var workbook = new XLWorkbook(_documentProviderOptions.HeroDocPath);
            var ws1 = workbook.Worksheet(1);

            foreach(var row in ws1.Rows().Skip(1))
            {
                yield return new HeroDTO
                {
                    Name = row.Cell(1).GetString(),
                    HeroName = row.Cell(2).GetString(),
                    Age = !string.IsNullOrEmpty(row.Cell(3).GetString()) ? Convert.ToInt32(row.Cell(3).GetString()) : null,
                    Gender = !string.IsNullOrEmpty(row.Cell(4).GetString()) ? Convert.ToChar(row.Cell(4).GetString()) : null
                };
            }
        }
    }
}
