using System;
using UnityEngine;

namespace Cells
{
    [Serializable]
    public class TileColor
    {
        [SerializeField]
        private int _id;
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
            }
        }

        public static bool operator ==(TileColor c1, TileColor c2)
        {
            if (c1 == null || c2 == null) return false;
            return c1==c2 || c1.Id == c2.Id;
        }
    
        public static bool operator !=(TileColor c1, TileColor c2)
        {
            if (c1 == null || c2 == null) return true;
            return c1 !=c2 && c1.Id != c2.Id;
        }
        protected bool Equals(TileColor other)
        {
            return _id == other._id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((TileColor)obj);
        }

        public override int GetHashCode()
        {
            return _id;
        }
    }
}