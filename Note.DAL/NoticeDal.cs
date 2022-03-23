using Microsoft.Extensions.Configuration;
using Note.DAL.DataContext;
using Note.IDAL;
using Note.Model;
using System.Collections.Generic;
using System.Linq;

namespace Note.DAL
{
    public class NoticeDal : INoticeDal
    {
        private readonly IConfiguration _configuration;

        public NoticeDal(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        List<Notice> INoticeDal.GetNoticeList()
        {
            using (var db = new NoteDbContext(_configuration))
            {
                return db.Notices
                    .OrderByDescending(n => n.NoticeNo)
                    .ToList();
            }
            //using (var db = new NoteDbContext())
            //{
            //    return db.Notices
            //        .OrderByDescending(n => n.NoticeNo)
            //        .ToList();
            //}
        }

        Notice INoticeDal.GetNotice(int noticeNo)
        {
            throw new System.NotImplementedException();
        }

        bool INoticeDal.PostNotice(Notice notice)
        {
            throw new System.NotImplementedException();
        }

        bool INoticeDal.UpdateNotice(Notice notice)
        {
            throw new System.NotImplementedException();
        }

        bool INoticeDal.DeleteNotice(int noticeNo)
        {
            throw new System.NotImplementedException();
        }
    }
}
