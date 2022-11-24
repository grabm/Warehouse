using System.Collections.Generic;
using System.Linq;

namespace Warehouse.Api.Domain
{
    public class DocumentPZ : Document
    {
        public DocumentPZ(string documentNumber, IEnumerable<DocumentItem> items) : base(documentNumber, items)
        {
            bool quantityLessThanZero = items.Any(x => x.Quantity < 0);

            if (quantityLessThanZero)
                throw new System.Exception("Dokument PZ akceptuje tylko dodatni stan produktu");
        }

        public override void Approve()
        {
            base.Approve();

            // TODO: add event approved document PZ
        }

        public override bool ValidateUpdate(IEnumerable<DocumentItem> items) => items.Any(x => x.Quantity < 0);
    }
}
