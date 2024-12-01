namespace Notes.Models
{
    internal class About
    {
        public string Title => "Stefan Jativa";  // Usamos tu nombre
        public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://aka.ms/maui";
        public string Message => "Soy una persona muy concurrente y me gusta hacer muchas cosas a la vez :)";  // Descripción personalizada en español
        public string Icon { get; set; }  // Foto
    }
}
