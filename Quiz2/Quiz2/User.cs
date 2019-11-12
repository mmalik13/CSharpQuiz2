using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2 {
    class User {
        private String fname;
        private String lname;
        private String tel;


        public User(String fname, String lname, String tel) {
            this.fname = fname;
            this.lname = lname;
            this.tel = tel;
        }

        public void setFName(String fname) {
            this.fname = fname;
        }

        public String getFName() {
            return fname;
        }

        public void setLName(String lname) {
            this.lname = lname;
        }

        public String getLName() {
            return lname;
        }

        public void setTel(String tel) {
            this.tel = tel;
        }

        public String getTel() {
            return tel;
        }


    }
}
