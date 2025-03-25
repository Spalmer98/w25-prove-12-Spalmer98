# W12 Prove: Individual Assignment
## Test Cases
#### Test Case 1
**Add items to queue and check if full**

Expected output:
* Size: 6
* 1
* 2
* 3
* 4
* 5
* 6

#### Test Case 2
**Add then remove item from queue**

Expected output:
* 1
* 2
* 3
* 4
* 5 
* 1
* 3
* 5
* Queue is empty.

#### Test Case 3
**Add item then peek at the first item in queue**

Expected output:
* 1
* 2
* 3
* 4
* 5 
* 1
* 3
* Queue is empty.

#### Test Case 4
**Add item then check to see if the queue contains an item**

Expected output:
* 1
* 2
* 3
* True
* False
* True
* False

#### Performance Measurements

|   Test   |   10   |  100   |  1000   |   10000  |  100000   |   1000000  |    Average    |
|:--------:|:------:|:------:|:-------:|:--------:|:---------:|:----------:|:-------------:|
|  Enqueue |  0 ms  |  0 ms  |   0 ms  |    0 ms  |     1 ms  |     33 ms  |      5.666 ms |
|   Peek   |  0 ms  |  0 ms  |   0 ms  |    0 ms  |     6 ms  |     31 ms  |        7.4 ms |
| Contains |  0 ms  |  0 ms  |   4 ms  |  147 ms  |  6203 ms  | 625405 ms  | 105293.166 ms |
|  Dequeue |  0 ms  |  0 ms  |   0 ms  |    0 ms  |     3 ms  |     29 ms  |       5.33 ms |

* Compared to circular buffering with a fixed array this meathod takes longer to manipulate the queue but it is easier to program and allows for changing size of the queue itself. With a fixed array the queue size is permenently set at the start of the program while LinkedLists are able to change in size to accomidate additional data at the expense of increased execution time.

* Based on the performance tests I can clearly see that Enqueue, Peek, and Dequeu are all O(1) complexity because they maintain a consistance execution speed until the items reach 1,000,000 where they begin to jump to double digit speeds.
* The Contains function on the other hand appears to be an O(n) complexity because it's execution time clearly increases as the number of items/inputs increases. Once we reach 1,000,000 items we see a massive spike in time it takes to execute and causes the program to take a considerable amount of time to progress.