using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Entities {
    class Couser {
        public int Number { get; set; }

        public Couser(int number) {
            Number = number;
        }

        public override bool Equals(object obj) {
            if (!(obj is Couser)) {
                return false;
            }
            Couser other = obj as Couser;
            return Number.Equals(other.Number);
        }

        public override int GetHashCode() {
            return Number.GetHashCode();
        }
    }
}
