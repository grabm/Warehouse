using System.Collections.Generic;
using System.Linq;

namespace Warehouse.Domain
{
    public class DocumentMM : Document
    {
        public DocumentMM(string documentNumber, IEnumerable<DocumentItem> items) : base(documentNumber, items)
        {
            bool quantityMoreThanZero = items.Any(x => x.Quantity > 0);

            if (quantityMoreThanZero)
                throw new Exception("Dokument WZ akceptuje tylko ujemny stan produktu");
        }

        public override void Approve()
        {
            base.Approve();

            // TODO: add event approved document MM
        }

        public override bool ValidateUpdate(IEnumerable<DocumentItem> items)
        {
            throw new NotImplementedException();
        }
    }
}
