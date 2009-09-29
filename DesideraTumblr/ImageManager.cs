using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesideraTumblr
{
    /// <summary>
    /// 読み込んだ画像・キャッシュ中の画像・表示中の画像などを管理するクラス
    /// </summary>
    public class ImageManager
    {
        private List<ImageData> CachedImages;

        ImageManager()
        {
            CachedImages = new List<ImageData>();
        }

        public void GetImage(int index, int num)
        {
        }
    }
}
