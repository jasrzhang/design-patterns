using FlyweightPattern;

Console.Title = "Flyweight";

var aBunchOfcharacters = "abba";

var characterFactory = new CharacterFactory();

// Get the flyweights(s)
var characterObject = characterFactory.GetCharacter(aBunchOfcharacters[0]);
// Pass through extrisic state
characterObject?.Draw("Arial", 12);


characterObject = characterFactory.GetCharacter(aBunchOfcharacters[1]);
characterObject?.Draw("Trebuchet MS", 14);

characterObject = characterFactory.GetCharacter(aBunchOfcharacters[2]);
characterObject?.Draw("Times New Roman", 16);

characterObject = characterFactory.GetCharacter(aBunchOfcharacters[3]);
characterObject?.Draw("Comic Sans", 18);

// create unshared concrete flyweight (paragraph)
var paragraph = characterFactory.CreateParagraph(new List<ICharacter>() { characterObject }, 1);

// draw the paragraph
paragraph.Draw("Lucinda", 12);