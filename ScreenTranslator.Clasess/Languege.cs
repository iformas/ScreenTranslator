using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace ScreenTranslator.Clasess
{
    public class Language
    {
        public String name { get; set; }
        public String gTranslateKey { get; set; }
        public String ocrKey { get; set; }

        public Language(String _name, String _gtranslatorKey, String _orcKey)
        {
            this.name = _name;
            this.gTranslateKey = _gtranslatorKey;
            this.ocrKey = _orcKey;
        }

        public static List<Language> Load(String path, String _fileName)
        {
            //un idioma puede o no tener una key orc
            //todos los idiomas deben tener la key de gtranslate
            try
            {
                if (File.Exists(path + "\\" + _fileName))
                {
                    using (StreamReader r = new StreamReader(_fileName))
                    {
                        string json = r.ReadToEnd();
                        var langueges = (JsonConvert.DeserializeObject<List<Language>>(json)).OrderBy(x => x.name).ToList();
                      
                        if (langueges.GroupBy(x => x.name.ToLower()).SelectMany(grp => grp.Skip(1)).Count() > 0)
                        {
                            throw new langDuplicateNamesException();
                        }

                        foreach (var lang in langueges)
                        {
                            if (lang.name == null)
                            {
                                throw new langMissingNameException();
                            }
                            if (lang.gTranslateKey == null)
                            {
                                throw new langMissingGTranslatekeyException(lang.name);
                            }
                        }
                        return langueges;
                    }
                }
                else
                {
                    throw new langConfigNotFoundException(_fileName);
                }
            }
            catch (JsonSerializationException) {
                throw new invalidLangJsonException();
            }

            catch (Exception)
            {
                throw;
            }

        }

        public static void Save(String _filename, List<Language> _langueges)
        {
            try
            {
                using (StreamWriter w = new StreamWriter(_filename))
                {
                    w.Write(JsonConvert.SerializeObject(_langueges));
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

       
    }
}
