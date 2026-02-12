namespace Bag.Models
{
    public class NotebooksRepo
    {
        private List<Notebook> notebooks = new List<Notebook>();
        private int nextId = 1;
        public IEnumerable<Notebook> GetAll()
        {
            return notebooks;
        }
        public Notebook? GetById(int id)
        {
            return notebooks.FirstOrDefault(n => n.Id == id);
        }
        public Notebook Add(Notebook notebook)
        {
            notebook.Id = nextId++;
            notebooks.Add(notebook);
            return notebook;
        }

        public Notebook? Remove(int id)
        {
            Notebook? notebook = GetById(id);

            if (notebook != null)
            {
                notebooks.Remove(notebook);
                return notebook;
            }
            return null;
        }
        public Notebook? Update(int id, Notebook notebook, Notebook updatedNotebookData)
        {
            Notebook? existingNotebookData = GetById(id);
            if (existingNotebookData != null)
            {
                existingNotebookData.Color = updatedNotebookData.Color;
                return existingNotebookData;
            }
            return null;
        }
    }
}
