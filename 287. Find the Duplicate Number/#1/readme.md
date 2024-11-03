# Solution 1

See more: [Link](https://leetcode.com/problems/find-the-duplicate-number/submissions/1438259566/)

![submission](./result.PNG "Submission result")

## Methodology

Consider this method as **brute force**, to frequently check for duplicates after the addition:

```cs
public class Solution {
    public int FindDuplicate(int[] nums) {
        List<int> finding_num = new List<int>();
        foreach (int num in nums)
        {
            if (finding_num.Contains(num))
                return num;
            finding_num.Add(num);
        }
        return -1;
    }
}
```

The idea for this solution (which is really simple imo) is to list through list of `nums`, adds each number inside a new list named `finding_num`:

```cs
	List<int> finding_num = new List<int>();
	foreach (int num in nums)
	{
		...
		finding_num.Add(num);
	}
```

Between each addition, there will be another check to see if the value (`num` in loops of `nums`) is in the list, by using:

```cs
	if (finding_num.Contains(num))
		return num;
```

This block of code will indicate that **the duplicate** is found, thus returning the said **duplicate** as ***the result*** of the algorithm. It was added before the addition to ensure that there is no *wasteful addition* into the list (welp, because the function is ended anyway).

## Performance
### Time complexity

![speed](./speed.PNG "Time complexity")
> Given `n` is the total number of elements in input `nums`.

**Total:** O(n^2).

**Explanation:**
- Running through the source array `nums`: ***O(n)***. `(1)`
- Running through tracing list `finding_num` (`finding_num.Contains(num)`): ***O(m)***. 
Worst case: no element found => running through the entire list => **m = n** => ***O(m) = O(n)***. `(2)`

**Conclusion:** `(2)` inside loop `(1)` => `(1)` x `(2)` = ***O(n^2)***

### Space complexity

![memory](./memory.PNG "Space complexity")
> Given `n` is the total number of elements in input `nums`.

**Total:** O(n^2)

**Explanation:**
- Input array `nums`: ***O(1)*** (constant). `(1)`
- Tracing list `finding_num`: *O(m)*. 
Worst case: no element found => running through entire `finding_num`: **m = n** => ***O(m) = O(n)***. `(2)`

**Conclusion:** `(1)` + `(2)` = *O(1) + O(n)* = ***O(n)***