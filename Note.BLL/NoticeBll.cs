using Note.IDAL;
using Note.Model;
using System;
using System.Collections.Generic;

namespace Note.BLL
{
    public class NoticeBll
    {
        private readonly INoticeDal _noticeDal;

        public NoticeBll(INoticeDal noticeDal)
        {
            _noticeDal = noticeDal;
        }

        public List<Notice> GetNoticeList()
        {
            return _noticeDal.GetNoticeList();
        }

        public Notice GetNotice(int noticeNo)
        {
            return _noticeDal.GetNotice(noticeNo);
        }

        public bool PostNotice(Notice notice)
        {
            if (null == notice)
            {
                throw new ArgumentNullException();
            }

            return _noticeDal.PostNotice(notice);
        }

        public bool UpdateNotice(Notice notice)
        {
            if (null == notice)
            {
                throw new ArgumentNullException();
            }

            return _noticeDal.UpdateNotice(notice);
        }

        public bool DeleteNotice(int noticeNo)
        {
            if (0 >= noticeNo)
            {
                throw new ArgumentNullException();
            }

            return _noticeDal.DeleteNotice(noticeNo);
        }

    }
}
