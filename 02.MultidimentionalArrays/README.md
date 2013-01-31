#02.MultidimentionalArrays

<hr />

####1. Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)


a)
<table border=1>
  <tbody>
    <tr>
      <td>1</td>
      <td>5</td>
      <td>9</td>
      <td>13</td>
    </tr>
    <tr>
      <td>2</td>
      <td>6</td>
      <td>10</td>
      <td>14</td>
    </tr>
    <tr>
      <td>3</td>
      <td>7</td>
      <td>11</td>
      <td>15</td>
    </tr>
    <tr>
      <td>4</td>
      <td>8</td>
      <td>12</td>
      <td>16</td>
    </tr>
  </tbody>
</table>

b)
<table border=1>
  <tbody>
    <tr>
      <td>1</td>
      <td>8</td>
      <td>9</td>
      <td>16</td>
    </tr>
    <tr>
      <td>2</td>
      <td>7</td>
      <td>10</td>
      <td>15</td>
    </tr>
    <tr>
      <td>3</td>
      <td>6</td>
      <td>11</td>
      <td>14</td>
    </tr>
    <tr>
      <td>4</td>
      <td>5</td>
      <td>12</td>
      <td>13</td>
    </tr>
  </tbody>
</table>

c)
<table border=1>
  <tbody>
    <tr>
      <td>7</td>
      <td>11</td>
      <td>14</td>
      <td>16</td>
    </tr>
    <tr>
      <td>4</td>
      <td>8</td>
      <td>12</td>
      <td>15</td>
    </tr>
    <tr>
      <td>2</td>
      <td>5</td>
      <td>9</td>
      <td>13</td>
    </tr>
    <tr>
      <td>1</td>
      <td>3</td>
      <td>6</td>
      <td>10</td>
    </tr>
  </tbody>
</table>

d) 
<table border=1>
  <tbody>
    <tr>
      <td>1</td>
      <td>12</td>
      <td>11</td>
      <td>10</td>
    </tr>
    <tr>
      <td>2</td>
      <td>13</td>
      <td>16</td>
      <td>9</td>
    </tr>
    <tr>
      <td>3</td>
      <td>14</td>
      <td>15</td>
      <td>8</td>
    </tr>
    <tr>
      <td>4</td>
      <td>5</td>
      <td>6</td>
      <td>7</td>
    </tr>
  </tbody>
</table>

####2. Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

####3. We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix. Example:

<table border=1>
  <tbody>
    <tr>
      <td><strong>ha</strong></td>
      <td>fifi</td>
      <td>ho</td>
      <td>hi</td>
    </tr>
    <tr>
      <td>fo</td>
      <td><strong>ha</strong></td>
      <td>hi</td>
      <td>xx</td>
    </tr>
    <tr>
      <td>xxx</td>
      <td>ho</td>
      <td><strong>ha</strong></td>
      <td>xx</td>
    </tr>
  </tbody>
</table>

Result: ha,ha,ha

####4. Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

####5. You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

####6. * Write a class Matrix, to holds a matrix of integers. Overload the operators for adding, subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().

####7. * Write a program that finds the largest area of equal neighbor elements in a rectangular matrix and prints its size. Example:

<table border=1>
  <tbody>
    <tr>
      <td>1</td>
      <td><strong>3</strong></td>
      <td>2</td>
      <td>2</td>
      <td>2</td>
      <td>4</td>
    </tr>
    <tr>
      <td><strong>3</strong></td>
      <td><strong>3</strong></td>
      <td><strong>3</strong></td>
      <td>2</td>
      <td>4</td>
      <td>4</td>
    </tr>
    <tr>
      <td>4</td>
      <td><strong>3</strong></td>
      <td>1</td>
      <td>2</td>
      <td><strong>3</strong></td>
      <td><strong>3</strong></td>
    </tr>
    <tr>
      <td>4</td>
      <td>3</td>
      <td>1</td>
      <td><strong>3</strong></td>
      <td><strong>3</strong></td>
      <td>1</td>
    </tr>
    <tr>
      <td>4</td>
      <td><strong>3</strong></td>
      <td><strong>3</strong></td>
      <td><strong>3</strong></td>
      <td>1</td>
      <td>1</td>
    </tr>
  </tbody>
</table>

Result: 13

Hint: you can use the algorithm "Depth-first search" or "Breadth-first search" (find them in Wikipedia).
