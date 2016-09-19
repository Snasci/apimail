# API Mail - A Modern Email Replacement

Reference code for a modern API replacement for email that does not require changing existing addresses.

API mail server is a modern replacement to the now ancient email system. The key difference is that an API is called, rather than a network level port. Email addresses remain the same and are parsed to construct a standard url (i.e. http://mydomain.com/mail/submit) to which a BSON payload is sent. This makes transitioning from existing email technologies to API-based mail a simple process of extension, rather than a complete break with existing approaches.

With CORS support, emails can be sent directly from the client side using javascript to the recipient domains, lowering costs for email providers.

This project is a very basic bare bones implementation, without any whistles or bells (or even error handling), but its enough to get the point. You will need to write the calling code for the API, just look at the MailContract.cs and use JSON/BSON.

The source is available under numerous licenses:

    Apache - http://www.apache.org/licenses/LICENSE-2.0
    BSD 3-Clause - https://opensource.org/licenses/BSD-3-Clause
    BSD 2-Clause - https://opensource.org/licenses/BSD-2-Clause
    WTFPL - http://www.wtfpl.net/about/
    MIT - https://opensource.org/licenses/MIT
    LGPL v3.0 - http://www.gnu.org/licenses/lgpl-3.0.en.html
    LGPL v2.1 - http://www.gnu.org/licenses/old-licenses/lgpl-2.1.en.html
    GPL v3.0 - http://www.gnu.org/licenses/gpl-3.0.en.html
    GPL v2.0 - http://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html 

