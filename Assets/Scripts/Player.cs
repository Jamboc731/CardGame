using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public List<Card> hand;
    public List<Card> deck;
    public int health;
    public Sprite art;
    public Card[] cardArray;
    public Canvas handCanvas;
    public GameObject points;
    public List<Transform> handPoints;
    public GameObject uiCard;
    public GameObject[] cardsOnScreen;

    private void Start ()
    {

        LoadCardsFromFolderToDeck ();
        deck = Shuffle (deck);

    }

    private void LoadCardsFromFolderToDeck ()
    {
        
        cardArray = Resources.LoadAll<Card>("Cards");
        deck = new List<Card> (cardArray);

    }
    
    private List<Card> Shuffle(List<Card> listToShuffle)
    {

        List<Card> shuffledList = new List<Card>();

        while(listToShuffle.Count > 0)
        {
            int current = Random.Range (0, listToShuffle.Count);
            shuffledList.Add (listToShuffle [current]);
            listToShuffle.RemoveAt (current);

        }

        return (shuffledList);

    }

    private void LoadCardsFromSceneToDeck ()
    {

        foreach (GameObject uiCard in GameObject.FindGameObjectsWithTag ("UICard"))
        {

            deck.Add (uiCard.GetComponent<CardDisplay> ().card);

        }

    }

    public void OutputCardNamesToConsole (List<Card> toOutput)
    {

        List<string> names = new List<string> ();
        foreach (Card item in toOutput)
        {

            names.Add (item.name.ToString ());

        }

        Debug.Log (string.Join (", ", names.ToArray ()));

    }

    public void Draw (int numberOfCards)
    {
        cardsOnScreen = GameObject.FindGameObjectsWithTag ("UICard");

        for(int i = 0; i < cardsOnScreen.Length; i++)
        {

            Destroy (cardsOnScreen [i]);

        }

        for(int i = 0; i < numberOfCards; i++)
        {

            if (hand.Count < 5)
            {
                hand.Add (deck [0]);
                deck.RemoveAt (0);
            }

        }

        DisplayHand ();

    }

    private void DisplayHand ()
    {

        for(int a = 0; a < hand.Count; a++)
        {

            GameObject current = DisplaySOWithUICard (hand[a]);
            current.transform.position = points.transform.GetChild (a).transform.position;
            //current.transform.rotation = Quaternion.Euler (35.08f, 0, 0);

        }

    }

    private GameObject DisplaySOWithUICard (Card toDisplay)
    {

        GameObject newUiCard = Instantiate (uiCard);
        newUiCard.transform.parent = handCanvas.transform;
        newUiCard.transform.localScale = new Vector3 (3, 3, 1);
        newUiCard.GetComponent<CardDisplay> ().card = toDisplay;

        return (newUiCard);
    }

    public void RemoveFromHand (GameObject UICard)
    {



    }

}