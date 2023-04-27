namespace BlazorKursApril227772.Pages.Modul4
{
    public class NachrichtenVM
    {
        public Action OnAdd;
        public List<ChatModel> ChatListe { get; set; }=new List<ChatModel>();
        public void Add(string msg)
        {

            ChatListe.Add(new ChatModel() { Nachricht=msg });
            OnAdd?.Invoke();
        }
    }
}
