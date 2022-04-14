namespace CodeMeetupRSVP.Models
{
    public class Repository
    {
        // In memory list of guest responses
        private static List<GuestResponse> responses = new();
        public static IEnumerable<GuestResponse> Responses => responses;

        public static void AddResponse(GuestResponse response)
        {
            Console.WriteLine(response);
            responses.Add(response);
        }
    }
}
