class Sort

  def self.quicksort(array, left=0, right=-1)

    return if array.nil? or array.length == 1

    if right < 0
      right = array.length - 1
    end

    i = left
    j = right

    pivot = array[Random.rand(array.length - 1)]

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

    if left < j
      quicksort array, left, j
    end

    if i < right
      quicksort array, i, right
    end

  end

end