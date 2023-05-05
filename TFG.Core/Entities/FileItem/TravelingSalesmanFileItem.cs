namespace TFG.Core.Entities.FileItem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using TFG.Core.Common.Enums.TSP;

    public class FileItem
    {
        public Guid Id { get; private set; }
        public string? Name { get; private set; }
        public ProblemType Problem { get; private set; }
        public string? Comment { get; private set; }
        public int Dimension { get; private set; }
        public int Capacity { get; private set; } = -1;
        public EDGE_WEIGHT_TYPE Edge_Weight_Type { get; private set; } = EDGE_WEIGHT_TYPE.NO_WEIGHT;
        public EDGE_WEIGHT_FORMAT Edge_Weight_Format { get; private set; } = EDGE_WEIGHT_FORMAT.NO_FORMAT;
        public EDGE_DATA_FORMAT Edge_Data_Format { get; private set; } = EDGE_DATA_FORMAT.NO_LIST;
        public NODE_COORD_TYPE Node_Coord_Type { get; private set; } = NODE_COORD_TYPE.NO_COORDS;
        public DISPLAY_DATA_TYPE Display_Data_Type { get; private set; } = DISPLAY_DATA_TYPE.NO_DISPLAY;

        public FileItem(string name, ProblemType problem, int dimension)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Problem = problem;
            this.Dimension = dimension;
        }
    }
}
