import React from 'react';

function SearchResults({ results }) {
  if (results.length === 0) {
    return <p>No flights found.</p>;
  }

  return (
    <table style={{ width: '100%', borderCollapse: 'collapse', marginTop: '20px' }}>
      <thead>
        <tr>
          <th style={{ border: '1px solid #ccc', padding: '10px' }}>From</th>
          <th style={{ border: '1px solid #ccc', padding: '10px' }}>To</th>
          <th style={{ border: '1px solid #ccc', padding: '10px' }}>Departure</th>
          <th style={{ border: '1px solid #ccc', padding: '10px' }}>Return</th>
          <th style={{ border: '1px solid #ccc', padding: '10px' }}>Passengers</th>
        </tr>
      </thead>
      <tbody>
        {results.map((result, index) => (
          <tr key={index}>
            <td style={{ border: '1px solid #ccc', padding: '10px' }}>{result.from}</td>
            <td style={{ border: '1px solid #ccc', padding: '10px' }}>{result.to}</td>
            <td style={{ border: '1px solid #ccc', padding: '10px' }}>{result.departure}</td>
            <td style={{ border: '1px solid #ccc', padding: '10px' }}>{result.return}</td>
            <td style={{ border: '1px solid #ccc', padding: '10px' }}>{result.passengers}</td>
          </tr>
        ))}
      </tbody>
    </table>
  );
}

export default SearchResults;
