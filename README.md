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

|   Test   |    1    |    2    |    3    |    4    |    5    |  Average  |
|:--------:|:-------:|:-------:|:-------:|:-------:|:-------:|:---------:|
|  Enqueue |  44 ms  |  40 ms  |  40 ms  |  42 ms  |  41 ms  |  41.4 ms  |
|   Peek   |  46 ms  |  41 ms  |  46 ms  |  43 ms  |  42 ms  |  43.6 ms  |
| Contains | 5872 ms | 5849 ms | 5777 ms | 5826 ms | 5809 ms | 5826.6 ms |
|  Dequeue |  30 ms  |  30 ms  |  30 ms  |  29 ms  |  31 ms  |   30 ms   |