using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Vector3D
    {

        private float m_x;
        private float m_y;
        private float m_z;

        public Vector3D() { }

        public Vector3D(float x, float y, float z)
        {
            m_x = x;
            m_y = y;
            m_z = z;
        }

        public static void stShow(Vector3D v)
        {
            Console.WriteLine("x = " + v.m_x + "; y = " + v.m_y + "; z = " + v.m_z);
        }

        public static Vector3D stAdd(Vector3D v1, Vector3D v2)
        {
            Vector3D vResult = new Vector3D(v1.m_x + v2.m_x, v1.m_y + v2.m_y, v1.m_z + v2.m_z);
            return vResult;
        }
        public void Show()
        {
            Console.WriteLine("x = " + m_x + "; y = " + m_y + "; z = " + m_z);
        }

        public Vector3D Add(Vector3D v)
        {
            Vector3D vResult = new Vector3D(m_x + v.m_x, m_y + v.m_y, m_z + v.m_z);
            return vResult;
        }


    }
}
