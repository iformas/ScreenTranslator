using System;


namespace ScreenTranslator.Clasess
{
    class invalidLangJsonException :  Exception
    {
        public invalidLangJsonException() : base("Languages config file invalid or corrupted ") { }
    }

    class langConfigNotFoundException : Exception
    {
        public langConfigNotFoundException(String _filename) : base("Languages config file \""+_filename+ "\" not found") { }
    }

    class langMissingNameException : Exception
    {
        public langMissingNameException() : base("Missing language name in config file") { }
    }
    class langMissingGTranslatekeyException : Exception
    {
        public langMissingGTranslatekeyException(String _langName) : base("Missing gTranslateKey for lang \""+_langName+"\"") { }
    }
    class langDuplicateNamesException : Exception
    {
        public langDuplicateNamesException() : base("Duplicate names for languages in config file") { }
    }

}
