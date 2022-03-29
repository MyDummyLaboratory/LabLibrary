using System;

namespace LabLibrary
{
    /// <summary>
    /// Class defining a point in 3D euclidean space
    /// </summary>
    public class Point
    {
        /// <summary>
        /// First coordinate of the point
        /// </summary>
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        /// <summary>
        /// Initialises a new <see cref="Point"/> class.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Point(double x, double y, double z)
        {
            X = x; Y = y; Z = z;
        }
    }
}
