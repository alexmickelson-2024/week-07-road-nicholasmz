namespace Week07Road.Logic
{
    public class Road : IRoad
    {
        private IVehicle[,] vehicles;
        public int RowCount { get; private set; }
        public int ColCount { get; private set; }

        public Road(int rows, int cols)
        {
            RowCount = rows;
            ColCount = cols;
            vehicles = new IVehicle[rows, cols];
        }

        public IVehicle? GetVehicle(int row, int col)
        {
            return vehicles[row, col];
        }

        public void SetVehicle(int row, int col, IVehicle vehicle)
        {
            vehicles[row, col] = vehicle;
        }
    }
}