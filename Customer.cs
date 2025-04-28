namespace miniERPModule
{
    internal partial class Program
    {
        class Customer
        {
            private int id;
            private string company;
            private string contactName;
            private string phoneNumber;
            private string email;

            public Customer(int id, string name, string pNum, string email, string company) {
                this.id = id;
                this.contactName = name;
                this.phoneNumber = pNum;
                this.email = email;
                this.company = company;
            }

            #region getters and setters
            public string Name {
                get { return contactName; }
                set { contactName = value; }
            }

            public int Id {
                get { return id; }
                set { id = value; }
            }

            public string PhoneNumber
            {
                get { return phoneNumber; }
                set { phoneNumber = value; }
            }

            public string Email
            {
                get { return email; }
                set { email = value; }
            }

            public string Company
            {
                get { return company; }
                set { company = value; }
            }
            #endregion

            public override string ToString() {
                return $"Customer ID:\t{this.id}\nCompany:\t{this.company}\nContact's name:\t{this.contactName}\nPhone number:\t{this.phoneNumber}\nE-mail:\t{this.email}";
            }
        }
    }
}
