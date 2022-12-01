using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Warehouse.Domain.Abstraction;

namespace Warehouse.Domain
{
    public abstract class Document : IAggregateRoot
    {
        private ICollection<DocumentItem> _items;

        public long Id { get; private set; }
        public string DocumentNumber { get; private set; }
        public bool IsApproved { get; private set; }
        public DateTime ApprovalDate { get; private set; }
        public DateTime CreateDate { get; private set; }
        public DateTime ModifiedDate { get; private set; }

        public IEnumerable<DocumentItem> Items => _items;
        public abstract bool ValidateUpdate(IEnumerable<DocumentItem> items);

        public Document(string documentNumber, IEnumerable<DocumentItem> items)
        {
            if (!items.Any())
                throw new Exception("Dokument musi mieć chociaż jedną pozycje");

            DocumentNumber = documentNumber;
            _items = items.ToList();
        }

        public void Update(IEnumerable<DocumentItem> items)
        {
            if (IsApproved)
                throw new Exception("Dokument nie może być edytowany bo został juz zatwierdzony");

            if (!ValidateUpdate(items))
                throw new Exception("TODO ERROR - do poprawy, kazdy dokument powinien zwrocic wlasny message");

            _items = items.ToList();
        }

        public virtual void Approve()
        {
            if (IsApproved)
                throw new Exception("Dokument został juz zatwierdzony");

            IsApproved = true;
        }
    }
}
