using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APIMail.Contracts;

namespace APIMail.Models
{
    public sealed class InMemoryDB
    {
        private static readonly InMemoryDB instance = new InMemoryDB();
        private List<MailContract> mailArchive = new List<MailContract>();

        private InMemoryDB() { }

        public static InMemoryDB Instance { get { return instance; } }

        public void AddMailToDB(MailContract mailContract)
        {
            mailArchive.Add(mailContract);
        }
    }
}