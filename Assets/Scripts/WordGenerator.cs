using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    //Array or random words; temporary
    private static string[] easyList = {"love", "root", "past", "feel", "hair", "long", "cut", "box", "sin", "pies", "spot", "head", 
	"mom", "mug", "hot", "tart", "join", "jump", "tray", "wax", "mute", "play", "heap", "rely", "boot",  "sick", "three", "robin", 
	"crack", "grade", "smash", "anger", "tasty", "spare", "daffy", "giant", "floor", "chief", "earth", "grate", "weird", "guide", 
	"cream", "wood", "pretty", "wound", "jazzy", "crate", "eager", "proud", "slice", "double", "ditch", "house", "retail", "thief", "tier", "glitter", "rubber", "biscuit",
	"flush", "money", "brain", "rugby", "theft", "merit", "slave", "mercy", "cower", "acute", "clash", "guest", "dream", "slime", "west", "knot", "date", "mile", "fine",
	"face", "call", "pity", "mold", "walk", "pipe", "long", "hero", "act", "key", "ton", "buy", "van", "god", "leg", "end", "pin", "gun", "lie", "car", "gas", "nun", "too",
	"you", "space", "ship", "alien", "word", "test", "age", "low", "dip", "sea"};

	private static string[] normalList = {"sidewalk", "protect", "periodic","somber", "majestic", "memory", "cloudy", "mother", "rustic", 
	"economic", "parallel", "interrupt", "signal", "abortive", "hilarious", "addition", "silent", "numerous", "friend", "pizza", "building", 
	"organic", "unusual", "mellow", "analyse", "homely", "protest", "society", "female", "dramatic", "present", "awesome",  "available", "sleet", 
	"boring", "scarce", "account",  "thought", "distinct", "nimble", "practise", "ablaze", "verdict", "garbage", "baseball", "hockey", "mattress", 
	"dashboard", "download", "professor", "landscape", "fabricate", "exercise", "neighborhood", "commercial", "important", "chestnut", "diagonal", "fireside", "fireplace", "framework",
	"otherwise", "recommend", "strategic", "amendment", "arguments", "automated", "chemicals", "departure", "highlight", "listening", "nutrients", "paragraph", "qualified", "residence",
	"scheduled", "stability", "telephone", "variation", "worldwide", "accounted", "algorithm", "appearing", "attacking", "condemned", "depressed", "disappear", "embracing", "exhibited",
	"favorable", "forefront", "generator", "guideline", "ignorance", "induction", "interiors", "launching", "academy", "zygosis", "zincing", "zeniths", "zanyism", "passive",
	"plastic", "storage", "gravity", "painter", "holiday", "fiction", "crusade", "retiree", "reflect", "parking", "battery", "unaware", "glacier", "default", "musical", "request", 
	"extract", "capital", "promise"};

	private static string[] hardList = {"painstaking", "thoughtless", "representative", "dangerous", "encouraging", "luminescent", "magnanimous", "accouterments", 
	"circumlocution", "superabundant", "unencumbered", "penultimate", "anachronistic", "cuddlesome", "desideratum", "equanimity", "gasconading", "grandiloquent", 
	"parsimonious", "perspicacious", "diagnostics", "gargantuan", "pharmacist", "administration", "understanding", "recommendation", "correspondence", "investigation",
	"comprehensive", "embarrassment", "consciousness", "representative", "confrontation", "environmental", "revolutionary", "consideration", "responsibility", "supplementary", 
	"strikebreaker", "communication", "characteristic", "extraterrestrial", "qualification", "identification", "preoccupation", "disappointment", "rehabilitation", "superintendent",
	"inappropriate", "constitutional", "discrimination", "concentration", "infrastructure", "demonstration", "constellation", "entertainment", "contradiction", "crinkum-crankum", "abnegation",
	"blandishment", "embezzlement", "heterogenous", "interlocutor", "legerdemain", "schadenfraude", "obstreperous", "boisterous", "philanthropic", "preponderance", "punctilious", "sanctimonious",
	"ubiquitous", "vicissitude", "vituperate", "otherworldly"};



    //Generate a random word from the array
    public static string GetRandomWord(int difficulty)
    {
		string[] wordList = normalList;
		if(difficulty == 1)
		{
			wordList = easyList;
		}
		else if(difficulty == 2)
		{
			wordList = normalList;
		}
		else
		{
			wordList = hardList;
		}
        int randomIndex = Random.Range(0, wordList.Length); // Create random index
        string randomWord = wordList[randomIndex]; // Find word at random index
        return randomWord;
    }
}
