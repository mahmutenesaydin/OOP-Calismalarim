using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _FacadeSample.Models
{
    public partial class Bank
    {
        public bool HasSufficientSavings(Customer cst,decimal amount)
        {
            using (FacadeDBEntities db = new FacadeDBEntities())
            {
                Customer customer = db.Customers.Find(cst.ID);
                Bank bank = db.Banks.Where(bnk => bnk.CustomerID == customer.ID).FirstOrDefault();
                return bank.CustomerAmount < amount ? true : false;
            }
        }
    }
    public partial class Credit
    {
        public bool HasGoodCredit(Customer cst)
        {
            using(FacadeDBEntities db = new FacadeDBEntities())
            {
                Customer customer = db.Customers.Find(cst.ID);
                Credit credit = db.Credits.Where(bnk => bnk.CustomerID == customer.ID).FirstOrDefault();
                return credit.CreditAmount < 200000 ? false : true;
            }
        }
    }
    public partial class Loan
    {
        public bool HasBadLoans(Customer cst)
        {
            using (FacadeDBEntities db = new FacadeDBEntities())
            {
                Customer customer = db.Customers.Find(cst.ID);
                Loan loan = db.Loans.Where(bnk => bnk.CustomerID == customer.ID).FirstOrDefault();
                return loan.LoanAmount > 50000 ? false : true;
            }
        }
    }
    public class Facade
    {
        private Bank _bank;
        private Credit _credit;
        private Loan _loan; 

        public Facade()
        {
            _bank = new Bank();
            _credit = new Credit();
            _loan = new Loan();
        }
        public bool Uygunmu(Customer cst,decimal amount)
        {
            bool uygun = true;
            if (!_bank.HasSufficientSavings(cst,amount))
            {
                uygun = false;
            }
            else if(_credit.HasGoodCredit(cst))
            {
                uygun = false;
            }
            else if(!_loan.HasBadLoans(cst))
            {
                uygun = false;
            }
            return uygun;
        }
    }
}
