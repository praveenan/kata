class Sort

  @@count = 0

  def self.quicksort(array, left=0, right=nil)

    puts @@count = @@count + 1

    return if array.nil?

    if right.nil? or right < 0
      right = array.length - 1
    end

    return if left >= right

    i = left
    j = right

    pivot = array[left]

    while i <= j

      while array[i] < pivot
        i = i + 1
      end

      while array[j] > pivot
        j = j - 1
      end

      if i < j
        temp = array[i]
        array[i] = array[j]
        array[j] = temp
      end

      if i <= j
        i = i + 1
        j = j - 1
      end

    end

    quicksort array, left, j

    quicksort array, i, right

  end

end