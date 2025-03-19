using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncBasicCancelToken2
{
    public class HunderedToZeroManager
    {
        private int _count;

        public bool CancelAsync { get; set; }

        // 1000 ~ 0 까지 카운팅 대리자를 통해 밖으로 카운트 전달
        public async Task Run(Action<int> countAction, CancellationToken token)
        {
            _count = 0;
            countAction.Invoke(_count);

            await Task.Run(() =>
            {
                while (_count > 0)
                {
                    if (CancelAsync)
                        break;
                    if (token.IsCancellationRequested)
                        break;

                    _count--;
                    countAction.Invoke(_count);
                    Thread.Sleep(20);
                }
            });
        }
    }
}
