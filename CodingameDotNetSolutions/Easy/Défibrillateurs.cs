using System.Globalization;

namespace CodingameDotNetSolutions.Easy;

class Défibrillateurs
{
    static void Main(string[] args)
    {
        double LON = ParseCoordinate(Console.ReadLine());
        double LAT = ParseCoordinate(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());

        var minDistance = double.MaxValue;
        var closestDefibName = "";

        for (int i = 0; i < N; i++)
        {
            string[] DEFIB = Console.ReadLine().Split(';');
            string defibName = DEFIB[1];
            double defibLongitude = ParseCoordinate(DEFIB[4]);
            double defibLatitude = ParseCoordinate(DEFIB[5]);

            double distance = CalculateDistance(LON, LAT, defibLongitude, defibLatitude);
            if (!(distance < minDistance)) continue;
            minDistance = distance;
            closestDefibName = defibName;
        }

        Console.WriteLine(closestDefibName);
    }

    static double CalculateDistance(double lonA, double latA, double lonB, double latB)
    {
        const double EarthRadiusKm = 6371.0;

        double latAInRadians = DegreesToRadians(latA);
        double latBInRadians = DegreesToRadians(latB);
        double lonDiffInRadians = DegreesToRadians(lonB - lonA);
        double latDiffInRadians = DegreesToRadians(latB - latA);

        double x = lonDiffInRadians * Math.Cos((latAInRadians + latBInRadians) / 2);
        double y = latDiffInRadians;

        return Math.Sqrt(x * x + y * y) * EarthRadiusKm;
    }

    static double DegreesToRadians(double degrees) => degrees * Math.PI / 180;

    static double ParseCoordinate(string coordinate)
    {
        return double.Parse(coordinate.Replace(',', '.'), CultureInfo.InvariantCulture);
    }
}