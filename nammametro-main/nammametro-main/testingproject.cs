public class testingProject
{
    static void main(string[] args)
    {
        Dictionary<string, string> greenLine = new Dictionary<string, string>();
        greenLine.Add("Cubbon Park", "CUB"); //0
        greenLine.Add("Rajajinagar", "RAJ"); //1
        greenLine.Add("Trinity", "TRN"); //2
        greenLine.Add("Baiyyapanhalli", "BYN"); //3
        greenLine.Add("Majestic", "MAJ"); //4
        greenLine.Add("Mulpur", "MUL"); //5
        greenLine.Add("Taj", "TAJ"); //6
        greenLine.Add("Mahal", "MAH"); //7
        Dictionary<string, string> purpleLine = new Dictionary<string, string>();
        purpleLine.Add("Hebbal", "HEB");
        purpleLine.Add("Mysore Road", "MYS");
        purpleLine.Add("Majestic", "MAJ");
        purpleLine.Add("Jayanagar", "JAY");
        purpleLine.Add("Halsuru", "HAL");
        purpleLine.Add("AIT", "AIT");
        purpleLine.Add("Stanxa", "STZ");

        Dictionary<string, List<string>> allstations = new Dictionary<string, List<string>>();

        List<string> greenLineList = new List<string>();
        List<string> templistgreen = new List<string>();
        foreach (KeyValuePair<string, string> station in greenLine)
        {
            greenLineList.Add(station.Value);
            templistgreen.Add(station.Key);


        }
        allstations.Add("green", templistgreen);
        List<string> templistpurple = new List<string>();
        List<string> purpleLineList = new List<string>();
        foreach (KeyValuePair<string, string> station in purpleLine)
        {
            purpleLineList.Add(station.Value);
            templistpurple.Add(station.Key);

        }
        allstations.Add("purple", templistpurple);






        IEnumerable<string> intersect = greenLineList.AsQueryable().Intersect(purpleLineList);
        string intersection = "";

        foreach (string s in intersect)
        {
            intersection = s;

        }
    }
}