using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public class Desk
    {
        int width;
        int depth;
        int drawerNum;
        String surfaceMaterial;
        int surfaceArea;
        

        public Desk(int width, int depth, int drawerNum, string surfaceMaterial)
        {
            this.width = width;
            this.depth = depth;
            this.drawerNum = drawerNum;
            this.surfaceMaterial = surfaceMaterial;
            surfaceArea = width * depth;
          
        }

        public int Width { get => width; set => width = value; }
        public int Depth { get => depth; set => depth = value; }
        public int DrawerNum { get => drawerNum; set => drawerNum = value; }
        public string SurfaceMaterial { get => surfaceMaterial; set => surfaceMaterial = value; }
        public int SurfaceArea { get => surfaceArea; set => surfaceArea = value; }
     
    }

    public enum DesktopMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }
}
