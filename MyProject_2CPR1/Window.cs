using System;
using Tao.OpenGl;

namespace MyProject_2CPR1
{
	
	public abstract class Window:GlObject
	{
		protected Point3D start=new Point3D(0,0,0);
		protected double angle;
		public abstract double Width { get; }
		public abstract double Height { get; }
		public virtual double Angle 
		{ 
			get { return angle;}
			set { angle=value; }
		}
		public virtual Point3D Location
		{ 
			get { return start;}
			set { start=value; }
		}

	}
}
