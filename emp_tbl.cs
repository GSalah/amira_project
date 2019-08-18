using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Spring
{
    #region Emp_tbl
    public class Emp_tbl
    {
        #region Member Variables
        protected int _id;
        protected string _name;
        protected string _email;
        protected string _address;
        protected string _telephone;
        #endregion
        #region Constructors
        public Emp_tbl() { }
        public Emp_tbl(string name, string email, string address, string telephone)
        {
            this._name=name;
            this._email=email;
            this._address=address;
            this._telephone=telephone;
        }
        #endregion
        #region Public Properties
        public virtual int Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual string Name
        {
            get {return _name;}
            set {_name=value;}
        }
        public virtual string Email
        {
            get {return _email;}
            set {_email=value;}
        }
        public virtual string Address
        {
            get {return _address;}
            set {_address=value;}
        }
        public virtual string Telephone
        {
            get {return _telephone;}
            set {_telephone=value;}
        }
        #endregion
    }
    #endregion
}