using System;
using System.Xml;

namespace Section01 {
    internal class xmlSerializer {
        private Type type;

        public xmlSerializer(Type type) {
            this.type = type;
        }

        internal void Serialize(XmlWriter writeer, Novel novel) {
            throw new NotImplementedException();
        }

        internal Novel Deserialize(XmlReader reader) {
            throw new NotImplementedException();
        }
    }
}