# W11 Prove: Individual Assignment
## Test Cases
#### Test Case 1
**Add items to queue and check if full**

Expected output:
* Queue if full.
* Size: 5
* 1
* 2
* 3
* 4
* 5

#### Test Case 2
**Add then remove item from queue**

Expected output:
* 1
* 2
* 3
* 4
* 5 
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

#### Test Case 4
**Add item then check to see if the queue contains an item**

Expected output:
* 1
* 2
* 3
* True
* False

#### Performance Measurements

|   Test   |   1   |   2   |   3   |   4   |   5   | Average |
|:--------:|:-----:|:-----:|:-----:|:-----:|:-----:|:-------:|
|  Enqueue |  7ms  |  7ms  |  7ms  |  7ms  |  6ms  |  6.8ms  |
|   Peek   |  2ms  |  2ms  |  2ms  |  2ms  |  2ms  |   2ms   |
| Contains | 353ms | 355ms | 361ms | 361ms | 360ms |  358ms  |
|  Dequeue |  6ms  |  6ms  |  6ms  |  6ms  |  6ms  |   6ms   |