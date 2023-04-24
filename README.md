# Unity-UIToolkit-ListViewHorizontal
Horizontal ListView for Unity's UI Toolkit.
The VisualElement has been created by decompiling and adapting Unity's vertical ListView.
Therefor, x / width / horizontal has been swapped with y / height / vertical.

Sadly, the ListView VisualElement from Unity does not provide horizontal direction, only vertical (see [Unity forum](https://forum.unity.com/threads/listview-horizontal-arrangements-of-items.909632/#post-8969272)), hence this workaround.

Note that some implementation details have been skipped either because internal API was not reachable or because I did not need these features.
Skipped features include
- DragAndDrop to reorder items
- dynamic item width
