public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var cars =
            position.Zip(speed, (pos, spd) => (pos, spd)).OrderByDescending(x => x.pos).ToArray();

        int fleets = 0;
        double time = 0;

        foreach (var car in cars) {
            double carTime = (double)(target - car.pos) / car.spd;

            if (carTime > time) {
                fleets++;
                time = carTime;
            }
        }
        return fleets;
    }
}
