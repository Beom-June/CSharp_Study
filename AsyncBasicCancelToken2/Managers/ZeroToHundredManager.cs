using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncBasicCancelToken2
{
    public class ZeroToHundredManager
    {
        private int _count;

        public bool Cancel { get; set; }

        // 0 ~ 100 까지 카운팅 대리자를 통해 밖으로 카운트 전달
        public async Task Run(Action<int> countAction, CancellationToken token)
        {
            _count = 0;
            countAction.Invoke(_count);

            await Task.Run(() =>
            {
                //Thread.Sleep(5000);                 //  Thread는 제어가 불가
                //bool _canceled = token.WaitHandle.WaitOne(5000);
                //if (_canceled)
                //{
                //    MessageBox.Show("취소 되었습니다");
                //}
                while (_count < 100)
                {
                    if (Cancel)
                        break;
                    if (token.IsCancellationRequested)
                        break;

                    _count++;
                    countAction.Invoke(_count);
                    Thread.Sleep(20);
                }
            });
        }
    }
}
