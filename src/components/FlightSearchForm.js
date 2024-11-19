import React, { useState } from 'react';

function FlightSearchForm({ onSearch }) {
  const [formData, setFormData] = useState({
    from: '',
    to: '',
    departure: '',
    return: '',
    passengers: 1,
  });

  const handleChange = (e) => {
    setFormData({ ...formData, [e.target.name]: e.target.value });
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    onSearch(formData);
  };

  return (
    <form
      onSubmit={handleSubmit}
      style={{
        display: 'flex',
        gap: '10px',
        flexWrap: 'wrap',
        backgroundColor: '#f1f1f1',
        padding: '20px',
        borderRadius: '10px',
        margin: '20px auto',
        maxWidth: '800px',
      }}
    >
      <label>
        From:
        <input
          type="text"
          name="from"
          value={formData.from}
          onChange={handleChange}
          style={{ marginLeft: '10px', padding: '5px' }}
        />
      </label>
      <label>
        To:
        <input
          type="text"
          name="to"
          value={formData.to}
          onChange={handleChange}
          style={{ marginLeft: '10px', padding: '5px' }}
        />
      </label>
      <label>
        Departure:
        <input
          type="date"
          name="departure"
          value={formData.departure}
          onChange={handleChange}
          style={{ marginLeft: '10px', padding: '5px' }}
        />
      </label>
      <label>
        Return:
        <input
          type="date"
          name="return"
          value={formData.return}
          onChange={handleChange}
          style={{ marginLeft: '10px', padding: '5px' }}
        />
      </label>
      <label>
        Passengers:
        <input
          type="number"
          name="passengers"
          value={formData.passengers}
          onChange={handleChange}
          style={{ marginLeft: '10px', padding: '5px', width: '60px' }}
          min="1"
        />
      </label>
      <button
        type="submit"
        style={{
          backgroundColor: '#003366',
          color: 'white',
          padding: '10px 20px',
          border: 'none',
          borderRadius: '5px',
          cursor: 'pointer',
        }}
      >
        Search Flights
      </button>
    </form>
  );
}

export default FlightSearchForm;
