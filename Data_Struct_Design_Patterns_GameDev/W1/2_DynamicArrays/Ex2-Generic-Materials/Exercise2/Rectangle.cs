using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    /// <summary>
    /// A rectangle
    /// </summary>
    class Rectangle : IComparable {
        #region Fields

        int width;
        int height;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates a rectangle with the given width and height
        /// </summary>
        /// <param name="width">width</param>
        /// <param name="height">height</param>
        public Rectangle(int width, int height) {
            this.width = width;
            this.height = height;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the width of the rectangle
        /// </summary>
        /// <value>width</value>
        public int Width {
            get { return width; }
        }

        /// <summary>
        /// Gets the height of the rectangle
        /// </summary>
        /// <value>height</value>
        public int Height {
            get { return height; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Converts the rectangle to a string
        /// </summary>
        /// <returns>string for the rectangle</returns>
        public override string ToString() {
            return string.Format("[Rectangle: Width={0}, Height={1}]", Width, Height);
        }

        /// <summary>
        /// Compares this rectangle to the parameter
        /// </summary>
        /// <param name="obj">other rectangle to compare to</param>
        /// <returns>Relative order</returns>
        public int CompareTo(Object obj) {
            // always graether than null
            if (obj == null) return 1;

            Rectangle otherRectangle = obj as Rectangle;
            if (otherRectangle != null) {
                int diff = width * height - otherRectangle.Width * otherRectangle.Height;
                if (diff > 0) return 1;
                else if (diff < 0) return -1;
                else return 0;
            } else throw new ArgumentException("Object is not a Rectangle");
        }
        #endregion
    }
}
