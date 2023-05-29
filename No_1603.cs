namespace LeetCode
{
    /// <summary>
    /// Problema No 1603
    /// </summary>
    public class ParkingSystem
    {
        int _big = 0, _medium = 0, _small = 0;

        public ParkingSystem(int big, int medium, int small)
        {
            this._big = big;
            this._medium = medium;
            this._small = small;
        }

        public bool AddCar(int carType)
        {
            switch (carType)
            {
                case 1:
                    if (_big > 0)
                    {
                        _big--;
                        return true;
                    }
                    break;
                case 2:
                    if (_medium > 0)
                    {
                        _medium--;
                        return true;
                    }
                    break;
                case 3:
                    if (_small > 0)
                    {
                        _small--;
                        return true;
                    }
                    break;
            }
            return false;

        }
    }
}