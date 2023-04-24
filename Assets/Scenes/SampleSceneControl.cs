using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SampleSceneControl : MonoBehaviour
{
    private ListViewH listView;

    private void Awake()
    {
        listView = FindObjectOfType<UIDocument>().rootVisualElement.Q<ListViewH>();
    }

    void Start()
    {
        BindListView();
    }

    private void BindListView()
    {
        // Create a list of data. In this case, numbers from 1 to 1000.
        const int itemCount = 1000;
        var items = new List<string>(itemCount);
        for (int i = 1; i <= itemCount; i++)
            items.Add(i.ToString());

        // The "makeItem" function is called when the
        // ListView needs more items to render.
        listView.makeItem = () =>
        {
            var label = new Label();
            label.style.width = listView.fixedItemWidth;
            label.style.color = Color.white;
            label.style.fontSize = 18;
            return label;
        };

        // As the user scrolls through the list, the ListView object
        // recycles elements created by the "makeItem" function,
        // and invoke the "bindItem" callback to associate
        // the element with the matching data item (specified as an index in the list).
        listView.bindItem = (element, index) =>
        {
            (element as Label).text = items[index];
        };

        // Provide the list view with an explicit height for every row
        // so it can calculate how many items to actually display
        listView.onItemsChosen += objects => Debug.Log(objects);
        listView.onSelectionChange += objects => Debug.Log(objects);
        
        // Set the list's data source
        listView.itemsSource = items;
    }
}