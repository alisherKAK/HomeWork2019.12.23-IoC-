using HomeWork2019._12._23_Autofac_.AbstractModels;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace HomeWork2019._12._23_1_.Services
{
    public class JsonRepository<T> : IRepository<T> where T : class, IEntity
    {
        private string _filePath;
        public string FilePath { set { _filePath = value; } }
        public JsonRepository() { }
        public JsonRepository(string filePath)
        {
            _filePath = filePath;
        }

        public void Add(T item)
        {
            string result;
            using (var streamReader = new StreamReader(_filePath))
            {
                result = streamReader.ReadToEnd();
            }

            using (var streamWriter = new StreamWriter(_filePath))
            {
                var users = JsonConvert.DeserializeObject<List<T>>(result);
                users.Add(item);
                streamWriter.Write(JsonConvert.SerializeObject(users));
            }
        }

        public void Delete(T item)
        {
            string result;
            using (var streamReader = new StreamReader(_filePath))
            {
                result = streamReader.ReadToEnd();
            }

            using(var streamWriter = new StreamWriter(_filePath))
            {
                var users = JsonConvert.DeserializeObject<List<T>>(result);
                users.Remove(item);
                streamWriter.Write(JsonConvert.SerializeObject(users));
            }
        }

        public void Delete(int id)
        {
            string result;
            using (var streamReader = new StreamReader(_filePath))
            {
                result = streamReader.ReadToEnd();
            }

            using (var streamWriter = new StreamWriter(_filePath))
            {
                var users = JsonConvert.DeserializeObject<List<T>>(result);
                var user = users.Find(u => u.Id == id);
                users.Remove(user);
                streamWriter.Write(JsonConvert.SerializeObject(users));
            }
        }

        public IEnumerable<T> GetAll()
        {
            string result;
            using (var streamReader = new StreamReader(_filePath))
            {
                result = streamReader.ReadToEnd();
            }

            using (var streamWriter = new StreamWriter(_filePath))
            {
                var users = JsonConvert.DeserializeObject<List<T>>(result);
                return users;
            }
        }

        public void Update(T item)
        {
            string result;
            using (var streamReader = new StreamReader(_filePath))
            {
                result = streamReader.ReadToEnd();
            }

            using (var streamWriter = new StreamWriter(_filePath))
            {
                var users = JsonConvert.DeserializeObject<List<T>>(result);
                users.Remove(item);
                users.Add(item);
                streamWriter.Write(JsonConvert.SerializeObject(users));
            }
        }
    }
}
