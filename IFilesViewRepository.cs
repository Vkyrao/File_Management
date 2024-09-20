using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public interface IFilesViewRepository
    {
        FilesView GetFilesView(int id);

        List<FilesView> GetFilesViews();

        void InsertFilesView(FilesView filesView);

        void UpdateFilesView(FilesView filesView);

        void DeleteFilesView(int id);
    }
}

