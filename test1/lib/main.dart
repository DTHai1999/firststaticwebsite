import 'package:flutter/material.dart';
void main() => runApp(new MyApp());

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return new MaterialApp(
      title: " Flutter Demo Calculator App",
      home: new HomePage(),
    );
  }
}
class HomePage extends StatefulWidget {
  @override
  State createState() => new HomePageState();
}
class HomePageState extends State<HomePage> {
  var num1 = 0, num2 = 0, sum = 0;
  final TextEditingController txt1 = new TextEditingController(text: "");
  final TextEditingController txt2 = new TextEditingController(text: "");
  void doCong() {
    setState(() {
      num1 = int.parse(txt1.text);
      num2 = int.parse(txt2.text);
      sum = num1 + num2;
    });
  }
  void doTru() {
    setState(() {
      num1 = int.parse(txt1.text);
      num2 = int.parse(txt2.text);
      sum = num1 - num2;
    });
  }
  void doNhan() {
    setState(() {
      num1 = int.parse(txt1.text);
      num2 = int.parse(txt2.text);
      sum = num1 * num2;
    });
  }
  void doChia() {
    setState(() {
      num1 = int.parse(txt1.text);
      num2 = int.parse(txt2.text);
      sum = num1 ~/ num2;
    });
  }
  @override
  Widget build(BuildContext context) {
    return new Scaffold(
      appBar: new AppBar(
        title: new Text(" Flutter Demo Calculator"),
      ),
      body: new Container(
        padding: const EdgeInsets.all(20.0),
        child: new Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: <Widget>[

            new TextField(
              keyboardType: TextInputType.number,
              maxLength: 10,
              controller: txt1,
            ),

            new TextField(
              keyboardType: TextInputType.number,
              maxLength: 10,
              controller: txt2,
            ),
            new Padding(padding:const EdgeInsets.only(top:30.0)
            ),
            new Text(
              "$sum.0",
              style: new TextStyle(
                  fontSize: 20.0,
                  fontWeight: FontWeight.bold,
                  color: Colors.black),
            ),
            new Padding(
              padding: const EdgeInsets.only(top: 30.0),
            ),
            new Row(
              mainAxisAlignment: MainAxisAlignment.end,
              children: <Widget>[
                new MaterialButton(
                  child: new Text("+"),
                  color: Colors.blue,
                  onPressed: doCong,
                ),
                new MaterialButton(
                  child: new Text("-"),
                  color: Colors.blueGrey,
                  onPressed: doTru,
                ),
              ],
            ),

            new Row(
              mainAxisAlignment: MainAxisAlignment.end,
              children: <Widget>[
                new MaterialButton(
                  child: new Text("*"),
                  color: Colors.lightBlueAccent,
                  onPressed: doNhan,
                ),
                new MaterialButton(
                  child: new Text("/"),
                  color: Colors.blue,
                  onPressed: doChia,
                ),
              ],
            ),
            new Padding(
              padding: const EdgeInsets.only(top: 20.0),
            ),
            new Row(
              mainAxisAlignment: MainAxisAlignment.center,
              children: <Widget>[
              ],
            )
          ],
        ),
      ),
    );
  }
}
