using System;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class QuestionSets {
    public string Question { get; set; }
    public string[] Wrong { get; set; }
    public string Right { get; set; }
}

public class A {

}


public class buttonScript : MonoBehaviour {
    static string a = "test";
    QuestionSets firstQuestion = new QuestionSets { Question = "What ’t’ will this find?: /t$/ ", Wrong = new string[] { a, "better", "tea"}, Right = "eat"  };
    // Use this for initialization
    void Start () {
        GameObject.Find("Button1").GetComponentInChildren<Text>().text = firstQuestion.Wrong[UnityEngine.Random.Range(0, 3)];
    }

	// Update is called once per frame
	void Update () {

	}
}

//string[,] test = { { "Question",  "What ’t’ will this find?: /t$/ " }, { "Choice1", "eater" }, { "Choice2", "better" }, { "Choice3", "tea" }, { "Answer", "eat" } };
