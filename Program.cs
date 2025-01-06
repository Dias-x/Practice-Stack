Stack<int> stack = new Stack<int>();

/*Push() -> Wert hinzufügen
 Peek() -> Gibt den letzten hinzugefügten Wert aus ohne zu löschen
 Pop() -> Gibt den letzten hinzugefügten Wert aus und löscht es dann*/

//Stack Liste hinzufügen
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);

/*Stack Liste = ausgabe des letzten hinzugefügten Wertes "5"
ibt den Wert der Liste wieder zurück*/
Console.WriteLine(stack.Peek());

/*Stack Liste = ausgabe des letzten hinzugefügten Wertes "5"
dazu wird es von der Liste gelöscht*/
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());

/*Stack Liste = ausgabe des letzten hinzugefügten Wertes "5"
 gibt den Wert der Liste wieder zurück*/
Console.WriteLine(stack.Peek());
Console.WriteLine(stack.Peek());