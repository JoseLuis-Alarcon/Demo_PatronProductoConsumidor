using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_PatronProductoConsumidor
{
    public class Cola<T>
    {
        private readonly Queue<T> _queue = new Queue<T>();
        private readonly int _capacidadMaxima;

        public Cola(int capacidadMaxima)
        {
            _capacidadMaxima = capacidadMaxima;
        }

        public void Agregar(T item)
        {
            lock (_queue)
            {
                while (_queue.Count >= _capacidadMaxima)
                {
                    Monitor.Wait(_queue);
                }

                _queue.Enqueue(item);
                Monitor.PulseAll(_queue);
            }
        }

        public T Extraer()
        {
            lock (_queue)
            {
                while (_queue.Count == 0)
                {
                    Monitor.Wait(_queue);
                }

                T item = _queue.Dequeue();
                Monitor.PulseAll(_queue);
                return item;
            }
        }
    }
}
