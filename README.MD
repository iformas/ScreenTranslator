Screen Translator
===================

Detect the text in your screen using Emgu CV for instant translation via Google Translate.

----------

Requeriments
-------------

#### <i class="icon-file"></i> OCR Training Data
This software requires OCR training data for screen text recognition in the folder “tessdata”.
Training data samples for different languages can be found [here](https://github.com/tesseract-ocr/tessdata)




#### <i class="icon-file"></i> languages.json 

You need to create a file called langueges.json containing the languages info

Example 1

    [{"name":"Spanish","gTranslateKey":"es","ocrKey":"spa"},{"name":"English","gTranslateKey":"en","ocrKey":"eng"}]
Example 2

    [{"name":"Spanish","gTranslateKey":"es”},{"name":"English","gTranslateKey":"en","ocrKey":"eng"}]
Where

 - **Name**: Unique long language name.
 - **gTranslateKey**: Represents the language [supported](https://cloud.google.com/translate/v2/translate-reference#supported_languages) by google translate API.
 - **orcKey**: Represents the language supported by openCV placed in “tessdata” folder.