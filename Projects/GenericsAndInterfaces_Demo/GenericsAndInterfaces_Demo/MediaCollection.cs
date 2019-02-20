using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndInterfaces_Demo
{
    class MediaCollection<T> where T : IMedia
    {
        List<T> collection = new List<T>();

        public MediaCollection()
        {
            
        }

        public void Add(T obj)
        {
            collection.Add(obj);
        }

        public void OpenOrPlay(T file)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(file.Path);
            player.Play();
        }
    }
}
